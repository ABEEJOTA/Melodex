import axios from "axios";

export function useMediaItems(setMediaItems){
    const GetMediaItems = async () => {
        await axios.
        get("https://localhost:7033/api/MediaItem").
        then((response) => setMediaItems(response.data));
    }

    return{
        GetMediaItems
    } 
}