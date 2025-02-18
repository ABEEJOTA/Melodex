type Vinyl = {
    id: string,
    title: string,
    releaseYear: number,
    genre: string,
    label: string,
    notes: string,
    imageUrl: URL
  };
  
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