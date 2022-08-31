import { useState } from "react";
import { UserResourceDetails } from "./user-resource-details";
import { UserResourceItem } from "./user-resource-item";
import "../style/user-resource-slider.css"

export const UserResourceSlider = ({genreId, genreName }) => {
    const [detailId, setDetailId] = useState(0);
    const [clicked, setClicked] = useState(0);
    const [active, setActive] = useState(false);

    const handleItemClick = (e) => {
        setDetailId(e.target.id);
        if (clicked === e.target.id) {
            setActive(!active);
            return setClicked("0");
        }
        setClicked(e.target.id);
        setActive(true);
    }

    return (
        <>
            <p>{genreName}</p>
            <div className="genre-container">
                <UserResourceItem itemId="1" click={handleItemClick} />
                <UserResourceItem itemId="2" click={handleItemClick} />
                <UserResourceItem itemId="3" click={handleItemClick} />
                <UserResourceItem itemId="4" click={handleItemClick} />
                <UserResourceItem itemId="5" click={handleItemClick} />
            </div>
            <div className={`${active ? "" : "detail-hide"}`}>
                <UserResourceDetails resourceId={detailId} />
            </div>
        </>
    );
}
