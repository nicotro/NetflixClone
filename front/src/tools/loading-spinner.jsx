import "./../style/loading-spinner.css"

export const LoadingSpinner = () => {
    return (
        <div className="spinner-container">
            <div id="loading-bar-spinner" className="spinner">
                <div className="spinner-icon">
                </div>
            </div>
        </div>
    );
}

