import css from '../Table/Table.module.css';
import TextTitle from '../utils/TextTitle';
export default function Table(){
    return(
        <>
        <div className={css.divtitle}>
            <TextTitle textTitle='Monitoreando'></TextTitle>
        </div>
        <div className={css.div}>
            
            <table className={css.table}>
                <tr>
                    <th className={css.th}>N° Equipo</th>
                    <th className={css.th}>Modelo</th>
                    <th className={css.th}>CPU</th>
                    <th className={css.th}>Ultima Actualización</th>
                    <th className={css.th}>Ubicación Actual</th>
                    <th className={css.th}>Zona Segura</th>
                </tr>
                <tr>
                    <td className={css.td}>1</td>
                    <td className={css.td}>Lenovo Idspiron</td>
                    <td className={css.td}>AMD A9 9450</td>
                    <td className={css.td}>16/12/2022</td>
                    <td className={css.td}><a href='#' className={css.a}>VER MAPA</a></td>
                    <td className={css.td}><p className={css.psi}>Si</p></td>
                </tr>
                <tr>
                    <td className={css.td}>2</td>
                    <td className={css.td}>Lenovo Idspiron</td>
                    <td className={css.td}>AMD A9 9450</td>
                    <td className={css.td}>16/12/2022</td>
                    <td className={css.td}><a href='#' className={css.a}>VER MAPA</a></td>
                    <td className={css.td}><p className={css.psi}>Si</p></td>
                </tr>
                <tr>
                    <td className={css.td}>3</td>
                    <td className={css.td}>Lenovo Idspiron</td>
                    <td className={css.td}>AMD A9 9450</td>
                    <td className={css.td}>16/12/2022</td>
                    <td className={css.td}><a href='#' className={css.a}>VER MAPA</a></td>
                    <td className={css.td}><p className={css.psi}>Si</p></td>
                </tr>
                <tr>
                    <td className={css.td}>4</td>
                    <td className={css.td}>Lenovo Idspiron</td>
                    <td className={css.td}>AMD A9 9450</td>
                    <td className={css.td}>16/12/2022</td>
                    <td className={css.td}><a href='#' className={css.a}>VER MAPA</a></td>
                    <td className={css.td}><p className={css.psi}>Si</p></td>
                </tr>
                <tr>
                    <td className={css.td}>5</td>
                    <td className={css.td}>Lenovo Idspiron</td>
                    <td className={css.td}>AMD A9 9450</td>
                    <td className={css.td}>16/12/2022</td>
                    <td className={css.td}><a href='#' className={css.a}>VER MAPA</a></td>
                    <td className={css.td}><p className={css.pno}>No</p></td>
                </tr>
            </table>
        </div>
        </>
   );
}
