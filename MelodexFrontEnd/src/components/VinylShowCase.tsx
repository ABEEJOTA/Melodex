import { Vinyl } from "../constants/Vinyl";
  
interface VinylShowCaseProps {
    vinyl: Vinyl;
}

export default function VinylShowCase ({vinyl}: VinylShowCaseProps) {

    return (
        <div>
            {vinyl.title}
        </div>
    );
}