import type { AppProps } from 'next/app'
import '../../app/globals.css'
import { RecoilRoot } from 'recoil'
import { Toaster } from '@/components/ui/toaster'

export default function App({ Component, pageProps }: AppProps) {
  return (
    <RecoilRoot>
      <Component {...pageProps} />
      <Toaster />
    </RecoilRoot>
  )
}
