import React, { FormEvent, useState } from 'react'
import MessageContainer from './MessageContainer'
import { Input } from '../ui/input'
import { useRecoilValue } from 'recoil'
import { ConnectionState } from '../../../states/ChatStates'
import { useToast } from '../ui/use-toast'
import { Button } from '../ui/button'
import { ChatInvokes } from '../../../dto/chat'

function Chat() {
  const { toast } = useToast()
  const connection = useRecoilValue(ConnectionState)
  console.log('connection', connection?.state)
  const [message, setMessage] = useState('')

  const sendMessage = async () => {
    console.log('message', message)
    try {
      if (connection) {
        await connection.invoke(ChatInvokes.SEND_MESSAGE, message)
      }
    } catch (error) {
      console.log('error', error)
      toast({
        title: 'Something went wrong in Sending Message',
        variant: 'destructive',
      })
    }
  }

  const closeConnection = async () => {
    try {
      if (connection) await connection?.stop()
    } catch (error) {
      toast({
        title: 'Something went wrong in Closing',
        variant: 'destructive',
      })
    }
  }

  return (
    <div className="relative">
      <div className="flex items-center justify-between mb-2">
        <h1 className="font-extrabold text-slate-700 mb-2 text-2xl">Chat</h1>
        <Button variant="destructive" onClick={closeConnection}>
          Close
        </Button>
      </div>
      <MessageContainer />
      <div className="flex items-center gap-2 sticky bottom-3 bg-transparent">
        <Input
          value={message}
          onChange={(e) => setMessage(e.target.value)}
          placeholder="Enter Message"
          className="shadow-md"
        />
        <Button onClick={sendMessage}>Send</Button>
      </div>
    </div>
  )
}

export default Chat
