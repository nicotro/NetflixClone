import axios from 'axios'

const urlFaq = "http://localhost:5274/api/v1/faq";

export const getAll = async () => {
    return await axios.get(urlFaq);
}




