import { useEffect, useState } from 'react';
import { HomeFaqItem } from './home-faq-item';
import { RegisterStart } from './register-start';
import { getAll } from '../services/Data-faq';
import HomeFaqData from './../data/faq.json';
import './../style/home-section.css'

export function HomeFaqSection() {

    const [clicked, setClicked] = useState("0");
    const [faqData, setFaqData] = useState([]);


    // A tester !
    useEffect(() => {
        getAll()
            .then(res => {
                setFaqData(res.data);
            })
            .catch((err) => {
                setFaqData([...HomeFaqData,
                    {"id":4,"question":"What type of error is this?",
                    "answer":`${err.name} on request ${err.config.method} ${err.config.url}`}
                ]);
            });
    }, [])

    // useEffect(() => {
    //     getFaqData();
    // }, [])


    // const getFaqData = () => {
    //     axios.get("http://localhost:5274/api/v1/faq").then(res => {
    //         setFaqData(res.data);
    //         // add json if api not available
    //     })
    // }

    const HandleToggle = (itemId) => {
        if (clicked === itemId) {
            return setClicked("0");
        }
        setClicked(itemId);
    }

    return (
        <div className='home-section'>
            <h1 className='home-section-title home-section-title-faq'>Frequently Asked Questions</h1>
            <ul className='home-section-faq'>
                {/* {HomeFaqData.map((faq) => ( */}
                {faqData.map((faq) => (
                    <li className='faq-list-item' key={faq.id}>
                        {/* <HomeFaqItem q={`${faq.q}`} a={`${faq.a}`} onToggle={() => HandleToggle(faq.id)} active={clicked === faq.id} /> */}
                        <HomeFaqItem q={`${faq.question}`} a={`${faq.answer}`} onToggle={() => HandleToggle(faq.id)} active={clicked === faq.id} />
                    </li>
                ))}
            </ul>
            <RegisterStart />
        </div>
    );
}
