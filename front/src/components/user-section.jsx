import { useEffect, useState } from "react";
import { getGenres } from "../services/db-access";
import { UserResourceSlider } from "./user-resource-slider";

export function UserSection({ category }) {
    const [genres, setGenres] = useState(category);
    const [loaded, setLoaded] = useState(false);
    const [oldCategory, setOldCategory]=useState(category);
    // const genreURL = "/genre";
    
    
    useEffect(() => {
        const genreURL = `/genre/${category}`;
        if (loaded === false || oldCategory!==category) {
            getGenres(genreURL)
                .then(res => {
                    setGenres(res.data);
                    setLoaded(true);
                    console.log(genreURL,res.data);
                    setOldCategory(category);
                })
                .catch(err => {
                    console.log("error", err);
                })
        }
    }, [loaded,category]);


    return (
        <>
            {loaded
                ?
                < div className="debug-white-text">
                    {/* <p>Category = {category}</p> */}
                    {genres.map((g) => (
                        <UserResourceSlider key={g.id} genreId={g.name} />)
                    )}
                </div>
                :
                < div className="debug-white-text">
                    <p>Loading...</p>
                </div>
            }
        </>
    );
}