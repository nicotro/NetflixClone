export function UserResourceItem({ itemId, click }) {
    return (
        <div id={itemId} class="genre-item" onClick={click}>
            item #{itemId}
        </div>
    );
}
