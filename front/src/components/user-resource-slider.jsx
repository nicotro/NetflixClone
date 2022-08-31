import { useEffect, useState } from "react";
import { UserResourceDetails } from "./user-resource-details";
import { UserResourceItem } from "./user-resource-item";
import "../style/user-resource-slider.css"
import { getResources } from "../services/db-access";

export const UserResourceSlider = ({ category, genre }) => {
    const [detailId, setDetailId] = useState(0);
    const [clicked, setClicked] = useState(0);
    const [active, setActive] = useState(false);
    const [resources, setResources] = useState([]);
    const [loaded, setLoaded] = useState(false);

    useEffect(() => {
        const resourcesURL = `/resource/rg/${category}/${genre.id}`;
        if (loaded === false) {
            getResources(resourcesURL)
                .then(res => {
                    setResources(res.data);
                    setLoaded(true);
                })
                .catch(err => {
                })
        }
    }, [loaded]);

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
            <p>{genre.name}</p>
            {loaded
                ?
                <>
                    <div className="genre-container">
                        {resources.map((r) => (
                            (r.genresId.includes(genre.id)) && <UserResourceItem key={r.id} item={r} click={handleItemClick} />)
                        )}
                        {/* 
                        <UserResourceItem itemId="1" click={handleItemClick} />
                        <UserResourceItem itemId="2" click={handleItemClick} />
                        <UserResourceItem itemId="3" click={handleItemClick} />
                        <UserResourceItem itemId="4" click={handleItemClick} />
                        <UserResourceItem itemId="5" click={handleItemClick} /> */}
                    </div>
                    {active
                        ?
                        <UserResourceDetails resource={resources.find(r => r.id == detailId)} />
                        :
                        <></>
                    }

                    {/* <div className={`${active ? "" : "detail-hide"}`}>
                        <UserResourceDetails resource={resources.find(r=>r.id==detailId)}/>
                    </div> */}
                </>
                :
                <div>
                    <p>Loading...</p>
                </div>
            }
        </>
    );
}
