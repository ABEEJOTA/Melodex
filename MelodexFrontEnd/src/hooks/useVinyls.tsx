import axios from "axios";

export function useVinyls(setMediaItems : any){
    const GetVinyls = async () => {
        await axios.
        get("https://localhost:7033/api/Vinyl").
        then((response) => setMediaItems(response.data));
    }

    return{
        GetVinyls
    } 
}