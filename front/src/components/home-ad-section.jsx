import HomeAdData from './../data/home-ad.json'
import './../style/home-section.css'

export function HomeAdSection() {
    return (
        <div className='home-section-container'>
            {HomeAdData.map((ad) => (
                <div className={`home-section ${ad.flex}`} key={ad.id}>
                    <div className="home-section-col-large">
                        <h1 className='home-section-title'>{ad.textTitle}</h1>
                        <h2 className='home-section-text'>{ad.textBody}</h2>
                    </div>
                    <div className="home-section-col-small">
                        <div className="home-section-col-img" >
                            <img src={`${ad.image}`} alt={ad.imageAlt} />
                        </div>
                        {ad.animationType === "video"
                            ?
                            <div style={{ maxWidth: "100%" }}>
                                <div className="home-section-col-video" style={ad.animationPos} >
                                    <video src={`${ad.animation}`} muted autoPlay={"autoplay"} preload="auto" loop></video>
                                </div>
                            </div>
                            :
                            <div>nothing yet</div>
                        }
                    </div>
                </div>
            ))
            }
        </div >
    );
}
