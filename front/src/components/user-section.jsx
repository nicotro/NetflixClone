import { UserResourceSlider } from "./user-resource-slider";

export function UserSection({ category }) {
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