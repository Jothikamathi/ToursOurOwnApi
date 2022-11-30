import React, {useState} from 'react';
import './Tour.css';

const Tour = ({ toursId, tourImage, countries, price, information, removeTour}) =>{
    const [readMore, setReadMore ] = useState(false);
    
    return (
        <div className='whole'>
        <article className='single-tour'>
            <img id='a1' src={tourImage} alt={countries} />
            <footer>
                <div className='tour-info'>
                    <h2>{countries}</h2>
                    
                </div>
                <p>
                    {readMore ? information : `${information.substring(0,100)}`}
                    <button onClick={() => setReadMore(!readMore)}>
                        {readMore ? 'show less' : 'read more'}
                    </button>
                </p>
                <h4 className='tour-price'>{price}</h4>
                
                <button className='delete-btn' onClick={() => removeTour(toursId)}>
                    Not Interested
                </button>
            </footer>
        </article>
        </div>
    );
};
export default Tour;