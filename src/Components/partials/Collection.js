import React from 'react'
import CollectionItem from './CollectionItem'

const Collection = ({title}) => {
  return (
    <section className='collection-grid'>
        <div className="title">{title}</div>
        <div className="item-collection">
            <CollectionItem />
        </div>
    </section>
  )
}

export default Collection
