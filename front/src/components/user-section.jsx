import { useEffect, useState } from "react";
import { getGenres } from "../services/db-access";
import { UserResourceSlider } from "./user-resource-slider";

export function UserSection({ category }) {
    const [genres, setGenres] = useState(category);
    const [loaded, setLoaded] = useState(false);
    const genreURL = "/genre";

    useEffect(() => {
        if (loaded === false) {
            getGenres(genreURL)
                .then(res => {
                    setGenres(res.data);
                    setLoaded(true);
                })
                .catch(err => {
                    console.log("error", err);
                })
        }
    }, [loaded]);


    return (
        <>
            {loaded
                ?
                < div className="debug-white-text">
                    <p>Category = {category}</p>
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