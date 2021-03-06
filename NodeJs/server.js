var websocket = require('ws');

var callbackInitServer = ()=>{
    console.log("APEXServer is running.");
}

var wss = new websocket.Server({port:5500}, callbackInitServer);

var wsList = [];

wss.on("connection", (ws)=>{
    console.log("client connected.");
    wsList.push(ws);

    ws.on("message", (data)=>{
        console.log("send from client : " + data);
        BoardCast(data);
    });

    ws.on("close",()=>{
        console.log("client disconnected.");
        wsList = ArrayRemove(wsList, ws);
    });
});

function ArrayRemove(arr,value)
{
    return arr.filter((element)=>{
        return element != value;
    });
}

function BoardCast(data)
{
    for(var i = 0; i <wsList.length; i++)
    {
        wsList[i].send(data);
    }
}