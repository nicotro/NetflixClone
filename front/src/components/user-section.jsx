import { useEffect, useState } from "react";
import { getGenres } from "../services/db-access";
import { UserResourceSlider } from "./user-resource-slider";
import "./../style/user-section.css";

export function UserSection({ category }) {
    const [genres, setGenres] = useState(category);
    const [loaded, setLoaded] = useState(false);
    const [oldCategory, setOldCategory]=useState(category);
    
    useEffect(() => {
        const genreURL = `/genre/${category}`;
        if (loaded === false || oldCategory!==category) {
            getGenres(genreURL)
                .then(res => {
                    setGenres(res.data);
                    setLoaded(true);
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
                < div className="usersection-genre">
                    {genres.map((g) => (
                        <UserResourceSlider key={g.id} category={category} genre={g} />)
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