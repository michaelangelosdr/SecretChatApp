'use strict'

const Express = require('express')
const Https = require('https')
const WebSocket = require('ws')
const FileSystem = require('fs')
const app = Express()
app.use(function (req, res) {
    res.send({ msg: 'hello' })
})

const server = Https.createServer({
    key: FileSystem.readFileSync('key.pem'),
    cert: FileSystem.readFileSync('cert.pem'),
    passphrase: 'test'
}, app)
const wss = new WebSocket.Server({ server })
wss.on('connection', function connection(ws) {
    ws.on('message', function incoming(message) {
        console.log("Opened");
        ws.send("Opened server, received data");
        console.log('received: %s', message)

    })
    

})
server.listen(7070, function listening() {
    console.log('Listening on %d', server.address().port)
})