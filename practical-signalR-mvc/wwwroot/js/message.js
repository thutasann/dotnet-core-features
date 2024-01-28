'use strict'

var connection = new signalR.HubConnectionBuilder().withUrl('/messages').build()

connection.on('ReceiveMesssage', function (message) {
  var msg = message.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;')
  var div = document.createElement('div')
  div.innerHTML = msg + '<hr/>'
  document.getElementById('messages').appendChild(div)
})

connection.start().catch(function (err) {
  return console.error('Connection Error', err.toString())
})

document.getElementById('sendButton').addEventListener('click', function (event) {
  var message = document.getElementById('messageInput').value
  connection.invoke('SendMessageToAll', message).catch(function (err) {
    return console.error('SendMessageToAll Error', err.toString())
  })
  event.preventDefault()
})
