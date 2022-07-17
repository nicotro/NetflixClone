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
                        <img src={`${ad.image}`} alt={ad.imageAlt} className="home-section-col-img" />
                    </div>
                </div>
            ))}
        </div>
    );
}
