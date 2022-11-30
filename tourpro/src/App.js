import React, {useState, useEffect} from "react";
import './App.css';

import Loading from "./Components/Loading";
import Tours from "./Components/Tours";

const url='https://localhost:7053/Tours/GetAllTours'

function App(){
  const [ loading, setLoading ] = useState(true)
  const [ tours , setTours] = useState([])
 
  
  const removeTour = (toursId) => {
    const newTours = tours.filter((tour) => tour.toursId !== toursId)
    setTours(newTours);
    
  }


  const fetchTours = async () => {
    setLoading(true)
    try {
      const response = await fetch(url)
      const tours = await response.json()
      setLoading(false)
      setTours(tours)
      
    }
    catch (error) {
      setLoading(false)
      console.log(error)
    }

    }
    useEffect(() => {
      fetchTours()
    }, [])
    if (loading) {
      return (
        <main>
          <Loading />
        </main>
      )
    }
    if(tours.length === 0){
      return (
        <main>
          <div className="title">
            <h2>NO TOURS LEFT</h2>
            <button className='btn' onClick={() => fetchTours()}>
              refresh
            </button>
          </div>
        </main>
      )
    } 
    return (
         <main>
        <Tours tours={tours} removeTour={removeTour} />
        </main>
    )
  }

export default App;
