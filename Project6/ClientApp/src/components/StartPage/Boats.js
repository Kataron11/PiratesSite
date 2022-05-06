import { useEffect, useState } from "react";
import BoatItem from "./BoatItem";

function Boats() {

    const [boatList, setBoatList] = useState([]);

    useEffect(() => {
        fetch('api/Shop/GetBoats', { method: 'GET' })
            .then(response => response.json())
            .then(data => setBoatList(data));
    }, []);

    function addBoat() {

    }

    const listItems = boatList.map((number) =>
        <BoatItem
            Name={number.name}
            Price={number.price}
            Speed={number.speed}
            Health={number.health}
            onClick={addBoat}
        ></BoatItem>
    );


    return (
        <div>
            {listItems}
        </div>
    );
}

export default Boats;