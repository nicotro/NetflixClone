import './../style/login-container.css'
import { Login } from './login';

export function LoginSection() {
    return (
        <div className="login-fade">
            <div className='login-container'>
                <div className='login-body'>
                    <h1>Sign In</h1>
                    <div className='modal-content'>
                        <Login />
                    </div>
                </div >
            </div >
        </div>
    );
}
