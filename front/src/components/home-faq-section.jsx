import { HomeFaqItem } from './home-faq-item';
import './../style/home-section.css'
import { RegisterStart } from './register-start';

export function HomeFaqSection() {
    return (
        <div className='home-section'>
            <h1 className='home-section-title home-section-title-faq'>Frequently Asked Questions</h1>
            <ul className='home-section-faq'>
                <li className='faq-list-item'><HomeFaqItem question="question 1" /> </li>
                <li className='faq-list-item'><HomeFaqItem question="question 2" /> </li>
                <li className='faq-list-item'><HomeFaqItem question="question 3" /> </li>
            </ul>
            <RegisterStart />
        </div>
    );
}
