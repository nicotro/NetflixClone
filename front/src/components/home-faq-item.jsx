import './../style/home-faq-item.css'
import { ReactComponent as Cross } from "./../assets/cross.svg"

export function HomeFaqItem({q,a,onToggle,active}) {
    return (
        <>
            <button className="faq-list-item-question" onClick={onToggle}>
                {q}
                <Cross className={`faq-list-item-question-svg ${active ? "cross" : ""}`} />
            </button>
            <div className={`faq-list-item-answer ${active ? "open" : ""}`}>
                <div className='faq-list-item-answer-text'>
                    {a}
                </div>
            </div>
        </>
    );
}

