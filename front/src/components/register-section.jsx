import './../style/register-section.css'
import { Register } from './register'

export function RegisterSection() {
    return (
        <div className="register-fade">
            <div className='register-container'>
                <div className='register-body'>
                    <h1>Sign Up</h1>
                    <Register />
                </div >
            </div >
        </div>
    );
}
