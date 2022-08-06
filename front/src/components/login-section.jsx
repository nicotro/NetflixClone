import './../style/login-section.css'
import { Login } from './login';

export function LoginSection() {
    return (
        <div className="login-fade">
            <div className='login-container'>
                <div className='login-body'>
                    <h1>Sign In</h1>
                    <Login />
                </div >
            </div >
        </div>
    );
}
