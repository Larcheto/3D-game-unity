import { InformationCard } from 'src/entity/InformationCard.entity'
import { getRepository } from 'typeorm'

export const initialiseDB = () => {
    const informationCards: InformationCard[] = getRepository(InformationCard).create([
        { content: 'bhdsalbsd', title: 'Card' },
        { content: 'bhdsalbsd', title: 'Card2' },
        { content: 'bhdsalbsd', title: 'Card3' }
    ])
    getRepository(InformationCard).save(informationCards)
}
