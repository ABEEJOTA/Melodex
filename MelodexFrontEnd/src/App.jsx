import { useState } from 'react'
import { useEffect } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { useMediaItems } from './hooks/useMediaItems'

function App() {
  const [data, setData] = useState(0);
  const [mediaItems, setMediaItems] = useState(null);
  const {GetMediaItems} = useMediaItems(setMediaItems);

  useEffect(()=>{
    console.log("MEDIA ITEMS", mediaItems);
  },[mediaItems])

  return (
    <>
      <div className="card">
        <button onClick={GetMediaItems}>
          Get Media Items
        </button>
      </div>
    </>
  )
}

export default App
