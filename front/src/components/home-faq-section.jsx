import { HomeFaqItem } from './home-faq-item';
import { RegisterStart } from './register-start';
import HomeFaqData from './../data/faq.json';
import './../style/home-section.css'

export function HomeFaqSection() {
    return (
        <div className='home-section'>
            <h1 className='home-section-title home-section-title-faq'>Frequently Asked Questions</h1>
            <ul className='home-section-faq'>
                {HomeFaqData.map((faq) => (
                    <li className='faq-list-item' key={faq.id}>
                        <HomeFaqItem q={`${faq.q}`} a={`${faq.a}`} />
                    </li>
                ))}
            </ul>
            <RegisterStart />
        </div>
    );
}
