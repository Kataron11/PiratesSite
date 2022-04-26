import { useState } from "react";
import BoatItem from "./BoatItem";

function Boats() {
    const [boatList, setBoatList] = useState([]);


    const listItems = boatList.map((number) =>
        <BoatItem
            Name={number.Name}
            Price={number.Price}
            Speed={number.Speed}
            Health={number.Health}
        ></BoatItem>
    );


    return (
        <div>
            {listItems}
        </div>
    );
}

export default Boats;