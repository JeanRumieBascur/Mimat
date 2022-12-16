import css from '../Navbar/Navbar.module.css';
export default function Navbar(){
    return(
        <>    
            <div className={css.div}>
            
            <ul>
                <li className={css.li}>
                    <img src='https://i.postimg.cc/KjTtq03W/bitmapmimat.png' className={css.img}></img>
                    <a className={css.a} href="#">Agregar</a>
                    <a className={css.a} href="#">Eliminar</a>
                </li>
            </ul>
            </div>
                  
        </>
    );
}