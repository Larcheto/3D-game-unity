import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm'

@Entity()
export class InformationCard {
    @PrimaryGeneratedColumn()
    id: number

    @Column()
    title: string

    @Column()
    content: string
}
