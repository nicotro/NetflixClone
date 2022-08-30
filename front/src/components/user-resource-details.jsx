import "../style/user-resource-details.css"

export function UserResourceDetails({ resourceId }) {
    return (
        <div className="detail-content">
            <div className="detail-background">
                <div className="detail-left"></div>
                <div className="detail-right"></div>
            </div>
            <div className="detail-content-container">
                <h1>Details media {resourceId}</h1>
                Lorem ipsum dolor sit, amet consectetur adipisicing elit. Voluptatibus magni nisi minima eum maiores hic nam consequatur ut maxime, architecto vero consequuntur veniam fugit et!
            </div>
        </div>
    );
}