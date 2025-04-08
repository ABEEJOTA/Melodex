import axios from "axios";

export function useVinyls(setVinyls : any){
    const GetVinyls = async () => {
        await axios.
        get("https://localhost:7033/api/Vinyl").
        then((response) => setVinyls(response.data));
    }

    return{
        GetVinyls
    } 
}