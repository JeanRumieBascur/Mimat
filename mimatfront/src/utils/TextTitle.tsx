import { string } from "yup";
import css from '../utils/TextTitle.module.css'

export default function TextTitle(prop: textTitle){
    return(
        <>
            <div className={css.div}>
                <h3 className={css.h3}>{prop.textTitle}</h3>
                <a href="#" className={css.a}>Actualizar</a>
            </div>
        </>
    );
}
interface textTitle{
    textTitle: string;
}