export function UserResourceItem({ item, click }) {
    return (
        <div id={item.id} className="genre-item" onClick={click}>
            <img src={item.images[1].uri} alt={item.name} id={item.id} />
            <p className="genre-item-text">id# {item.id} {item.name}</p>
        </div>
    );
}
