import { useState, useEffect } from 'react'
import { useVinyls } from '../hooks/useVinyls';
import VinylShowCase from '../components/VinylShowCase';

export default function Collection() {
  const [vinyls, setVinyls] = useState(null);
  const {GetVinyls} = useVinyls(setVinyls);

  useEffect(()=>{
    console.log("Vinyls", vinyls);
  },[vinyls])

  return (
    <>
      <div className="card">
        <button onClick={GetVinyls}>
          Get Media Items
        </button>
        {vinyls?
            <VinylShowCase vinyl={vinyls[0]}></VinylShowCase>
            : null
        }
      </div>
    </>
  )
}
