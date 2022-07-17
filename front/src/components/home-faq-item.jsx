import './../style/home-faq-item.css'

export function HomeFaqItem(props) {
    return (
        <div className='faq-list-item'>
            {props.q}
        </div>
    );
}
