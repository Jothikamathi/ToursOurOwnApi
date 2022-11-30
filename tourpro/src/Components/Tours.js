import React from "react";
import Tour from "./Tour";
import './Tours.css';

const Tours = ({ tours, removeTour }) => {
    return (
        <div className="a2">
        <section>
            <div className="section">
                <h1>OUR TOURS</h1>
                <div className="underline"></div>
            </div>
            <div>
                {tours.map((tour) => {
                    return <Tour key={tour.toursId} {...tour} removeTour={removeTour} />;
                                    })}
            </div>
        </section>
        </div>
    );

};
export default Tours;