'use strict'

const tokenSample =
  'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjY0MTBhNGU2OWU1NmFmYjI2MzkxYWUzOCIsImlhdCI6MTcwNjQzNDkzOCwiZXhwIjoxNzA5MDI2OTM4fQ.0goyrDRK8DJE2abziFQ09ECvc_lpAGM8BKNa7pX1JPE'

var connection = new signalR.HubConnectionBuilder()
  .withUrl('/messages', {
    accessTokenFactory: () => tokenSample,
  })
  .build()

connection.on('ReceiveMesssage', function (message) {
  var msg = message.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;')
  var div = document.createElement('div')
  div.innerHTML = msg + '<hr/>'
  document.getElementById('messages').appendChild(div)
})

connection.on('UserConnected', function (connectionId) {
  var groupElement = document.getElementById('group')
  var option = document.createElement('option')
  option.text = connectionId
  option.value = connectionId
  groupElement?.add(option)
})

connection.on('UserDisconnected', function (connectionId) {
  var groupElement = document.getElementById('group')
  for (let i = 0; i < groupElement.length; i++) {
    if (groupElement.options[i].value === connectionId) {
      groupElement.remove(i)
    }
  }
})

connection.start().catch(function (err) {
  return console.error('Connection Error', err.toString())
})

// Message Send Event
document.getElementById('sendButton').addEventListener('click', function (event) {
  var message = document.getElementById('messageInput').value
  var groupElement = document.getElementById('group')
  var groupValue = groupElement.options[groupElement.selectedIndex].value

  if (groupValue === 'All' || groupValue === 'Myself') {
    var method = groupValue === 'All' ? 'SendMessageToAll' : 'SendmessageToCaller'
    connection.invoke(method, message).catch(function (err) {
      return console.error('SendMessageToAll Error', err.toString())
    })
  } else if (groupValue === 'PrivateGroup') {
    connection.invoke('SendMessageToGroup', 'PrivateGroup', message).catch(function (err) {
      return console.error('SendMessageToGroup Error', err.toString())
    })
  } else {
    connection.invoke('SendMessageToUser', groupValue, message).catch(function (err) {
      return console.error('SendMessageToAll Error', err.toString())
    })
  }

  event.preventDefault()
})

// Join Group Event
document.getElementById('joinGroupBtn').addEventListener('click', function (event) {
  connection.invoke('JoinGroup', 'PrivateGroup').catch(function (err) {
    return console.error('Join Group Error', err.toString())
  })
  event.preventDefault()
})
