import React, { FormEvent, useState } from 'react'
import MessageContainer from './MessageContainer'
import { Input } from '../ui/input'
import { useRecoilValue } from 'recoil'
import { ConnectionState } from '../../../states/ChatStates'
import { useToast } from '../ui/use-toast'

function Chat() {
  const { toast } = useToast()
  const connection = useRecoilValue(ConnectionState)
  const [message, setMessage] = useState('')

  const sendMessage = async (e: FormEvent) => {
    e.preventDefault()
    try {
      if (!message) {
        toast({
          title: 'Please Enter message',
          variant: 'default',
        })
      }
      await connection?.invoke('SendMessage', message)
    } catch (error) {
      toast({
        title: 'Something went wrong in sending Message',
        variant: 'destructive',
      })
    }
    setMessage('')
  }

  return (
    <div className="relative">
      <h1 className="font-extrabold text-slate-700 mb-2 text-2xl">Chat</h1>
      <MessageContainer />
      <form onSubmit={sendMessage} className="sticky bottom-8 bg-transparent">
        <Input
          value={message}
          onChange={(e) => setMessage(e.target.value)}
          placeholder="Enter Message"
          className="shadow-md"
        />
      </form>
    </div>
  )
}

export default Chat
