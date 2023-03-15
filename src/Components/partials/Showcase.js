import React from 'react'
import { Link } from 'react-router-dom'
import ShowcaseImage from "../../Assets/images/showcase-img.png"

const Showcase = () => {
  return (
    <section className='showcase'>
<div className='container'>
    <div className='content'>
        <div className="title-2">GET UP TO 40% OFF</div>
        <div className="title-1">Don't miss this opportunity</div>
        <div className="title-3">Online shopping blabla</div>
        <Link className="btn-theme" to="/products">SHOP NOW</Link>
    </div>
    <img src={ShowcaseImage} alt="" />
</div>
    </section>
  )
}

export default Showcase
