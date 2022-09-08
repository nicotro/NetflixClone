import React from "react";
import ReactDOM from "react-dom";
import "./../style/user-resource-modal.css"

export const UserResourceModal = ({ isShowing, hide, resource }) =>

    isShowing
        ?
        ReactDOM.createPortal
            (
                <>
                    <div className="modal-overlay">
                        <div className="modal-wrapper">
                            <div className="modal">
                                <div className="modal-header">
                                    <h4>{resource.name}</h4>
                                    <button type="button" className="modal-close-button" onClick={hide}>
                                        <span>&times;</span>
                                    </button>
                                </div>
                                <div className="modal-body">
                                    <img className="modal-picture" src={resource.images[0].uri} alt={resource.name} />
                                </div>
                            </div>
                        </div>
                    </div>
                </>,
                document.body
            )
        :
        null;
