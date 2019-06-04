<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Dropofrunrankingaverage[]|\Cake\Collection\CollectionInterface $dropofrunrankingaverage
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Html->link(__('New Dropofrunrankingaverage'), ['action' => 'add']) ?></li>
    </ul>
</nav>
<div class="dropofrunrankingaverage index large-9 medium-8 columns content">
    <h3><?= __('Dropofrunrankingaverage') ?></h3>
    <table cellpadding="0" cellspacing="0">
        <thead>
            <tr>
                <th scope="col"><?= $this->Paginator->sort('Id') ?></th>
                <th scope="col"><?= $this->Paginator->sort('Name') ?></th>
                <th scope="col"><?= $this->Paginator->sort('Floor') ?></th>
                <th scope="col"><?= $this->Paginator->sort('Time') ?></th>
                <th scope="col"><?= $this->Paginator->sort('AverageTime') ?></th>
                <th scope="col" class="actions"><?= __('Actions') ?></th>
            </tr>
        </thead>
        <tbody>
            <?php foreach ($dropofrunrankingaverage as $dropofrunrankingaverage): ?>
            <tr>
                <td><?= $this->Number->format($dropofrunrankingaverage->Id) ?></td>
                <td><?= h($dropofrunrankingaverage->Name) ?></td>
                <td><?= $this->Number->format($dropofrunrankingaverage->Floor) ?></td>
                <td><?= $this->Number->format($dropofrunrankingaverage->Time) ?></td>
                <td><?= $this->Number->format($dropofrunrankingaverage->AverageTime) ?></td>
                <td class="actions">
                    <?= $this->Html->link(__('View'), ['action' => 'view', $dropofrunrankingaverage->Id]) ?>
                    <?= $this->Html->link(__('Edit'), ['action' => 'edit', $dropofrunrankingaverage->Id]) ?>
                    <?= $this->Form->postLink(__('Delete'), ['action' => 'delete', $dropofrunrankingaverage->Id], ['confirm' => __('Are you sure you want to delete # {0}?', $dropofrunrankingaverage->Id)]) ?>
                </td>
            </tr>
            <?php endforeach; ?>
        </tbody>
    </table>
    <div class="paginator">
        <ul class="pagination">
            <?= $this->Paginator->first('<< ' . __('first')) ?>
            <?= $this->Paginator->prev('< ' . __('previous')) ?>
            <?= $this->Paginator->numbers() ?>
            <?= $this->Paginator->next(__('next') . ' >') ?>
            <?= $this->Paginator->last(__('last') . ' >>') ?>
        </ul>
        <p><?= $this->Paginator->counter(['format' => __('Page {{page}} of {{pages}}, showing {{current}} record(s) out of {{count}} total')]) ?></p>
    </div>
</div>
