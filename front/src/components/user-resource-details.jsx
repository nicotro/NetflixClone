import { ReactComponent as Play } from "./../assets/play.svg"
import { useModal } from "../tools/use-modal";
import { UserResourceModal } from "./user-resource-modal";
import "../style/user-resource-details.css"

export function UserResourceDetails({ resource }) {

    const { isShowing, toggle } = useModal();

    return (
        <div className="detail-content" style={{ backgroundImage: `url(${resource.images[1].uri})` }}>
            <div className="detail-background">
                <div className="detail-left"></div>
                <div className="detail-right"></div>
            </div>
            <div className="detail-content-container">
                <h1>{resource.name}</h1>
                <p>{resource.infos}</p>
                <button className="detail-content-button" onClick={toggle}>
                    <Play className="detail-content-play"/>Play
                    </button>
            </div>
            <UserResourceModal isShowing={isShowing} hide={toggle} resource={resource}/>
        </div>
    );
}