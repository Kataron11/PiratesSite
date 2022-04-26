function BoatItem(props) {

    return (
        <li>
            <p>Nazwa : {props.Name}</p>
            <p>Szybkość : {props.Speed}</p>
            <p>Życie : {props.Health}</p>
            <p>Cena : {props.Price}</p>
        </li>
        );


}

export default BoatItem;