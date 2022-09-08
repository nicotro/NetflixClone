import { useEffect, useState, useRef } from "react";
import { UserResourceDetails } from "./user-resource-details";
import { UserResourceItem } from "./user-resource-item";
import { getResources } from "../services/db-access";
import { useNavigate } from "react-router-dom";
import "../style/user-resource-slider.css"

export const UserResourceSlider = ({ category, genre }) => {
    const [detailId, setDetailId] = useState(0);
    const [clicked, setClicked] = useState(0);
    const [active, setActive] = useState(false);
    const [resources, setResources] = useState([]);
    const [loaded, setLoaded] = useState(false);
    const [oldCategory, setOldCategory] = useState(category);
    const navigate = useNavigate();

    const activeRef = useRef() // add a "global" class to display only one detail panel

    useEffect(() => {
        const resourcesURL = `/resource/rg/${category}/${genre.id}`;
        if (loaded === false || oldCategory !== category) {
            getResources(resourcesURL)
                .then(res => {
                    setResources(res.data);
                    setLoaded(true);
                    setOldCategory(category);
                    setActive(false);
                })
                .catch(err => {
                    if (err.response.status === 401) {
                        navigate('/login')
                    }
                    console.log("http error", err.response);
                })
        }
    }, [loaded, category]);

    const handleItemClick = (e) => {
        setDetailId(e.target.id);
        if (clicked === e.target.id) {
            setActive(!active);
            return setClicked("0");
        }
        setClicked(e.target.id);
        setActive(true);
        console.log(e);
    }

    return (
        <>
            <p>{genre.name}</p>
            {loaded
                ?
                <>
                    <div className="genre-container">
                        <button className="arrows">
                            ‹
                        </button>
                        {resources.map((r) => (
                            (r.genresId.includes(genre.id)) && <UserResourceItem key={r.id} item={r} click={handleItemClick} />)
                        )}
                        <button className="arrows">
                            ›
                        </button>
                    </div>
                    {active
                        ?
                        <UserResourceDetails resource={resources.find(r => r.id == detailId)} />
                        :
                        <></>
                    }
                </>
                :
                <div>
                    <p>Loading...</p>
                </div>
            }
        </>
    );
}
