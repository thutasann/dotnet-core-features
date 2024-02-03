import React from 'react'
import { useRecoilValue } from 'recoil'
import { MessagesState } from '../../../states/ChatStates'

function MessageContainer() {
  const messsages = useRecoilValue(MessagesState)

  return (
    <section className="bg-gray-50 rounded-md relative h-[100vh] py-4 p-3">
      {messsages?.map((message, index) => {
        return (
          <div key={index} className="float-right relative">
            <div className="bg-blue-500 text-base text-green-50 py-2 px-3 rounded-full">{message.message}</div>
            <span className="text-xs text-slate-700 mt-1 font-semibold absolute right-0">{message.user}</span>
          </div>
        )
      })}
    </section>
  )
}

export default MessageContainer
