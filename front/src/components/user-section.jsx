import { useEffect, useState } from "react";
import { UserResourceSlider } from "./user-resource-slider";

export function UserSection({ category }) {
    const [loadedCategory,setLoadedCategory]=useState(category);
    
    useEffect(() => {
        
    }, []);
    
    return (
        <>
            < div className="debug-white-text">
                <p>Category = {category}</p>
                <UserResourceSlider genreId="Genre #1" />
                <UserResourceSlider genreId="Genre #2" />
            </div>
        </>
    );
}