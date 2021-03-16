import { InformationCard } from '../entity/InformationCard.entity'
import { getRepository } from 'typeorm'

export const initialiseDB = async () => {
    await getRepository(InformationCard).query('delete from information_card')
    const informationCards: InformationCard[] = getRepository(InformationCard).create([
        {
            content:
                'Тук е и гостната стая, където Вазов и близките му приятели проф. Иван Шишманов и Константин Величков са водили дълги, задушевни разговори.',
            title: 'Гостната стая'
        },
        {
            content:
                'Тук са разположени работната маса и личната библиотека на писателя, лични вещи, картини, портрети',
            title: 'Кабинета на Иван Вазов'
        },
        {
            content:
                'Къщата на Иван Вазов е построена през 1895 година и тук писателят е живял и работил най-дълго време. Сега в една от стаите на първия етаж се намира художествено-документалана експозиция, в която са изложени и някои от уникалните подаръци и награди, получени от народния поет за двата му юбилея през 1895 и 1920 години. ',
            title: 'Обща информация'
        }
    ])
    getRepository(InformationCard).save(informationCards)
}
