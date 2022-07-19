import './../style/home-faq-item.css'
import { ReactComponent as Cross } from "./../assets/cross.svg"

export function HomeFaqItem(props) {
    console.log(props);
    return (
        <div className='faq-list-item-question'>
            {props.q}
            <Cross className="faq-list-item-question-closed" />
        </div>
    );
}

