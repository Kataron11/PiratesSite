import { Button } from "reactstrap";

function BoatItem(props) {

    return (
        <li>
            <p>Nazwa : {props.Name}</p>
            <p>Szybkość : {props.Speed}</p>
            <p>Życie : {props.Health}</p>
            <p>Cena : {props.Price}</p>
            <Button>Kup</Button>
        </li>
        );


}

export default BoatItem;