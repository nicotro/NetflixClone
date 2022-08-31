import "../style/user-resource-details.css"

export function UserResourceDetails({ resource }) {
    return (
        <div className="detail-content" style={{ backgroundImage: `url(${resource.images[1].uri})` }}>
            <div className="detail-background">
                <div className="detail-left"></div>
                <div className="detail-right"></div>
            </div>
            <div className="detail-content-container">
                <h1>{resource.name}</h1>
                {resource.infos}
            </div>
        </div>
    );
}