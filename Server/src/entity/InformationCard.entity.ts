import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm'

@Entity({ synchronize: true })
export class InformationCard {
    @PrimaryGeneratedColumn()
    id: number

    @Column()
    title: string

    @Column()
    content: string
}
