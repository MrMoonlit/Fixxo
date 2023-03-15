import React from 'react'
import { NavLink } from 'react-router-dom'

const CollectionItem = () => {
  return (
    <div className='item'>
      <div className="image-section">
        <img src="https://kyhnet22sa.blob.core.windows.net/product-images/black-coat.png" alt="a black coat" />
        <div className='icons'>
            <button className='link'><i className="fa-regular fa-code-compare"></i></button>
            <button className='link'><i className="fa-regular fa-heart"></i></button>
            <button className='link'><i className="fa-regular fa-bag-shopping"></i></button>
        </div>
        <NavLink className="btn-theme">QUICK VIEW</NavLink>
      </div>
      <div className="body-section">
        
      </div>
    </div>
  )
}

export default CollectionItem
